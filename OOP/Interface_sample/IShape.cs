using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_sample
{
    interface IShape
    {
        // Không có field
        //int a

        // Không có method
        //public void DoSomeThing()
        //{

        //}

        // Chỉ có method Abstract, không cần từ khóa "public", "abstract"
        void DoThat();
    }
}
