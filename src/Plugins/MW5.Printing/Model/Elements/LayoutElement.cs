﻿// -------------------------------------------------------------------------------------------
// <copyright file="LayoutElement.cs" company="MapWindow OSS Team - www.mapwindow.org">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using MW5.Plugins.Printing.Controls.PropertyGrid;
using MW5.Plugins.Printing.Enums;
using MW5.Shared;

namespace MW5.Plugins.Printing.Model.Elements
{
    /// <summary>
    /// The interface for all elements that can be added to the layout control
    /// </summary>
    [Serializable]
    public abstract class LayoutElement
    {
        protected Font _font;
        protected Font _font2;
        private PointF _location;
        private String _name;
        private ResizeStyle _resizeStyle;
        private bool _resizing;
        internal SizeF _size;
        private Bitmap _thumbnail;

        public LayoutElement()
        {
            Visible = true;
        }

        /// <summary>
        /// Fires when the layout element is invalidated
        /// </summary>
        public event EventHandler Invalidated;

        /// <summary>
        /// Fires when the size of this element has been adjusted by the user
        /// </summary>
        public event EventHandler SizeChanged;

        /// <summary>
        /// Fires when the preview thumbnail for this element has been updated
        /// </summary>
        public event EventHandler ThumbnailChanged;

        [Browsable(false)]
        [DefaultValue(0)]
        [CategoryEx(@"cat_layout")]
        [DisplayNameEx(@"prop_height")]
        public float Height
        {
            get { return _size.Height; }
            set
            {
                _size.Height = value;
                SetSize();
            }
        }

        /// <summary>
        /// Gets or sets the location of the top left corner of the control in 1/100 of an inch paper coordinats
        /// </summary>
        [Browsable(true)]
        [CategoryEx(@"cat_layout")]
        [DisplayNameEx(@"prop_location")]
        public Point Location
        {
            get { return new Point(Convert.ToInt32(_location.X), Convert.ToInt32(_location.Y)); }
            set
            {
                _location = new PointF(value.X, value.Y);
                OnInvalidate();
            }
        }

        /// <summary>
        /// Gets or sets the location of the top left corner of the control in 1/100 of an inch paper coordinats
        /// </summary>
        [Browsable(false)]
        public PointF LocationF
        {
            get { return _location; }
            set
            {
                _location = value;
                OnInvalidate();
            }
        }

        /// <summary>
        /// Gets or sets the name of the element
        /// </summary>
        [Browsable(true)]
        [CategoryEx(@"cat_layout")]
        [DisplayNameEx(@"prop_name")]
        public String Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnInvalidate();
            }
        }

        /// <summary>
        /// Gets or sets the rectangle of the element in 1/100th of an inch paper coordinats
        /// </summary>
        [Browsable(false)]
        public RectangleF Rectangle
        {
            get { return new RectangleF(_location, _size); }
            set
            {
                if (value.Width < 10)
                {
                    value.Width = 10;
                    if (!NumericHelper.Equal(value.X, _location.X))
                    {
                        value.X = _location.X + _size.Width - 10;
                    }
                }

                if (value.Height < 10)
                {
                    value.Height = 10;

                    if (!NumericHelper.Equal(value.Y, _location.Y))
                    {
                        value.Y = _location.Y + _size.Height - 10;
                    }
                }

                _location = value.Location;
                _size = value.Size;

                OnSizeChanged();
                OnInvalidate();
                UpdateThumbnail();
            }
        }

        /// <summary>
        /// Indicates if this element can handle redraw events on resize
        /// </summary>
        [Browsable(false)]
        public ResizeStyle ResizeStyle
        {
            get { return _resizeStyle; }
            set { _resizeStyle = value; }
        }

        /// <summary>
        /// Disables updating redraw when resizing.
        /// </summary>
        [Browsable(false)]
        public bool Resizing
        {
            get { return _resizing; }
            set { _resizing = value; }
        }

        /// <summary>
        /// Gets or sets the size of the element in 1/100 of an inch paper coordinats
        /// </summary>
        [Browsable(false)]
        public SizeF Size
        {
            get { return new SizeF(_size.Width, _size.Height); }
            set
            {
                if (value.Width < 10) value.Width = 10;
                if (value.Height < 10) value.Height = 10;

                _size = value;

                OnSizeChanged();
                OnInvalidate();
                UpdateThumbnail();
            }
        }

        [Browsable(true)]
        [CategoryEx(@"cat_layout")]
        [DisplayNameEx(@"prop_size")]
        public Size SizeInt
        {
            get { return new Size((int)_size.Width, (int)_size.Height); }
            set { Size = value; }
        }

        /// <summary>
        /// Gets the thumbnail that appears in the LayoutListView
        /// </summary>
        [Browsable(false)]
        public Bitmap Thumbnail
        {
            get { return _thumbnail; }
            protected set
            {
                if (_thumbnail != null) _thumbnail.Dispose();
                _thumbnail = value;
                OnThumbnailChanged();
            }
        }

        [Browsable(false)]
        [CategoryEx(@"cat_layout")]
        [DisplayNameEx(@"prop_role")]
        public abstract ElementType Type { get; }

        [Browsable(true)]
        [DefaultValue(true)]
        [CategoryEx(@"cat_layout")]
        public bool Visible { get; set; }

        [Browsable(false)]
        [CategoryEx(@"cat_layout")]
        [DisplayNameEx(@"prop_width")]
        public float Width
        {
            get { return _size.Width; }
            set
            {
                _size.Width = value;
                SetSize();
            }
        }

        public bool ClickWithin(int x, int y)
        {
            return !(x < Location.X || x > Location.X + Size.Width || y < Location.Y || y > Location.Y + Size.Height);
        }

        /// <summary>
        /// Draws element. LayoutElement.Draw must be called through this method only
        /// </summary>
        public static void DrawElement(LayoutElement el, Graphics g, bool printing, bool export)
        {
            if (!el.Visible)
            {
                return;
            }

            var font = el._font;
            var font2 = el._font2;

            //el._font = printing ? Util.ScaleFont(el._font, ZoomableLayoutControl.LogicTo96Dpi) :
            //                      Util.ScaleFont(el._font, 1/ZoomableLayoutControl.LogicToScreenDpi);

            //el._font2 = printing ? Util.ScaleFont(el._font2, ZoomableLayoutControl.LogicTo96Dpi) :
            //                      Util.ScaleFont(el._font2, 1/ZoomableLayoutControl.LogicToScreenDpi);

            int x = printing ? 0 : el.Location.X;
            int y = printing ? 0 : el.Location.Y;

            el.Draw(g, printing, export, x, y);

            el._font = font;
            el._font2 = font2;
        }

        /// <summary>
        /// Returns true if the point in paper coordinats intersects with the rectangle of the element
        /// </summary>
        public bool IntersectsWith(PointF paperPoint)
        {
            return IntersectsWith(new RectangleF(paperPoint.X, paperPoint.Y, 0F, 0F));
        }

        /// <summary>
        /// Returns true if the rectangle in paper coordinats intersects with the rectangle of the the element
        /// </summary>
        public bool IntersectsWith(RectangleF paperRectangle)
        {
            return new RectangleF(LocationF, Size).IntersectsWith(paperRectangle);
        }

        /// <summary>
        /// Causes the element to be refreshed
        /// </summary>
        public virtual void RefreshElement()
        {
            OnSizeChanged();
            OnInvalidate();
            UpdateThumbnail();
        }

        /// <summary>
        /// This returns the objects name as a string
        /// </summary>
        public override string ToString()
        {
            return _name;
        }

        /// <summary>
        /// This gets called to instruct the element to draw itself in the appropriate spot of the graphics object
        /// </summary>
        protected abstract void Draw(Graphics g, bool printing, bool export, int x, int y);

        /// <summary>
        /// Call this when it needs to updated
        /// </summary>
        protected void OnInvalidate()
        {
            if (Invalidated != null) Invalidated(this, null);
        }

        /// <summary>
        /// Fires when the size of the element changes
        /// </summary>
        protected virtual void OnSizeChanged()
        {
            if (SizeChanged != null) SizeChanged(this, null);
        }

        /// <summary>
        /// Updates the thumbnail; works for all elements but map where screen buffer is used
        /// </summary>
        protected virtual void UpdateThumbnail()
        {
            if (Resizing || Size.Width < 1 || Size.Height < 1) return;

            var tempThumbnail = new Bitmap(32, 32, PixelFormat.Format32bppArgb);

            using (var graph = Graphics.FromImage(tempThumbnail))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                graph.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;

                if ((Size.Width / tempThumbnail.Width) > (Size.Height / tempThumbnail.Height))
                {
                    graph.ScaleTransform(32F / Size.Width, 32F / Size.Width);
                    graph.TranslateTransform(-LocationF.X, -LocationF.Y);
                }
                else
                {
                    graph.ScaleTransform(32F / Size.Height, 32F / Size.Height);
                    graph.TranslateTransform(-LocationF.X, -LocationF.Y);
                }

                graph.Clip = new Region(Rectangle);
                DrawElement(this, graph, false, false);
            }

            Thumbnail = tempThumbnail;
        }

        /// <summary>
        /// Fires when the thumbnail gets modified
        /// </summary>
        private void OnThumbnailChanged()
        {
            if (ThumbnailChanged != null) ThumbnailChanged(this, null);
        }

        private void SetSize()
        {
            if (Width < 10) Width = 10;
            if (Height < 10) Height = 10;

            OnSizeChanged();
            OnInvalidate();
            UpdateThumbnail();
        }
    }
}