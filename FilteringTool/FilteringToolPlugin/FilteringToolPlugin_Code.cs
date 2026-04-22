/* Copyright 2018 Dawid Dyrcz 
 * See License.txt file 
 */

using System;
using Tekla.Structures.Plugins;
using System.Collections.Generic;

namespace FilteringToolN
{
    public class FilteringToolPlugin_StructuresData
    {
        [StructuresField("someAttribute")]
        public string someAttribute;
    }

    [Plugin("Filtering Tool")] 
    [PluginUserInterface(nameof(FilteringToolN)+"."+nameof(StarterForm))]
    [InputObjectDependency(PluginBase.InputObjectDependency.NOT_DEPENDENT)]
   
    public class FilteringToolPlugin : PluginBase
    {
        private readonly FilteringToolPlugin_StructuresData _data;
        
        public FilteringToolPlugin(FilteringToolPlugin_StructuresData data)
        {
            _data = data;
        }

        public override List<InputDefinition> DefineInput()
        {
            throw new NotImplementedException();
        }

        public override bool Run(List<InputDefinition> Input)
        {
            throw new NotImplementedException();
        }

    }
}
