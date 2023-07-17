using System.Collections.Generic;
using Testing.Struct;

namespace Testing.Forms.Admin_Forms.Testers_Edit.Tester_edit
{
    internal class List_Tester_Edit
    {
        public List<Tester> Testers { set; get; }

        public List_Tester_Edit(List<Tester> testers)
        {
            Testers = testers;
        }
    }
}
