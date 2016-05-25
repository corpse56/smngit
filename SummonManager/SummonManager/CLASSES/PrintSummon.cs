using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SummonManager
{
    class PrintSummon
    {
        public PrintSummon()
        { }

        public void Print(SummonVO SVO)
        {
            SVO = SVO.FillReportFields();

        }

    }
}
