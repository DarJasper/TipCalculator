using System.Collections.Generic;
using TipCalculatorApp.Models;

namespace TipCalculatorApp.Repositories
{
    public interface ITipRepository
    {
        List<Tip> AddTip(Tip newTip);
        List<Tip> GetTips();
    }
}