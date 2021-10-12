using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282_Milestone2.BusinessLogicLayer
{
    class Module
    {
        public int moduleID;
        public string moduleName;
        public string moduleDescription;
        public string moduleLink;
        public Module() { }
        
        public int Module_ID { get => moduleID; set => moduleID = value; }
        public string Module_Name { get => moduleName; set => moduleName = value; }
        public string Module_Description { get => moduleDescription; set => moduleDescription = value; }
        public string Module_Link { get => moduleLink; set => moduleLink = value; }

        public Module(int moduleID, string moduleName, string moduleDescription, string moduleLink)
        {
            this.Module_ID = moduleID;
            this.Module_Name = moduleName;
            this.Module_Description = moduleDescription;
            this.Module_Link = moduleLink;

        }
    }
}
