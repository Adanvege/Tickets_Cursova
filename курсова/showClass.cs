using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace курсова
{
    internal class showClass
    {

        private string showName = "";
        private string showType = "";
        private int showCost = 0;
        private string showTown = "";
        private string showLink = "";

        public showClass(string showName, string showType, int showCost, string showTown, string showLink)
        {
            this.showName = showName;
            this.showType = showType;
            this.showCost = showCost;
            this.showTown = showTown;
            this.showLink = showLink;
        }

        public string getName() { return showName; }

        public string getType() { return showType; }

        public int getCost() { return showCost; }

        public string getTown() { return showTown; }

        public string getLink() { return showLink; }


    }
}
