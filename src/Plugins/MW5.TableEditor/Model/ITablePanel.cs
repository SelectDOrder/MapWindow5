﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MW5.Plugins.Interfaces;

namespace MW5.Plugins.TableEditor.Model
{
    public interface ITablePanel: IDockPanel
    {
        int LayerHandle { get; }
    }
}
