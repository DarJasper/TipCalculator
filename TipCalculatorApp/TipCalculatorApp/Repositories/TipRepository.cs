using System;
using System.Collections.Generic;
using System.Text;
using TipCalculatorApp.Models;

namespace TipCalculatorApp.Repositories
{
    public class TipRepository : ITipRepository
    {
        static List<Tip> tips = new List<Tip>();

        public List<Tip> GetTips()
        {
            return tips;
        }

        public List<Tip> AddTip(Tip newTip)
        {
            tips.Add(newTip);
            return tips;
        }

    }
}
