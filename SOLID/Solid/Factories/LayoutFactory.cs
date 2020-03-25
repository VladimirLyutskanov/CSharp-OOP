using Solid.Models.Contracts;
using Solid.Models.Layouts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.Factories
{
    public class LayoutFactory
    {
        public ILayout GetLayout(string type)
        {
            ILayout layout;

            if (type=="SimpleLayout")
            {
                layout = new SimpleLayout();
            }
            else if(type == "XmlLayout")
            {
                layout = new XmlLayout();
            }
            else
            {
                throw new InvalidOperationException("Invalid Layout Type!");
            }
            return layout;
        }
    }
}
