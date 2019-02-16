using System.Collections.Generic;
using TipCalculatorApp.Models;

namespace TipCalculatorApp.Services
{
    public interface ITipService
    {
        List<Tip> GetTips();
        List<Tip> SetTips(Tip newTip);
    }
}