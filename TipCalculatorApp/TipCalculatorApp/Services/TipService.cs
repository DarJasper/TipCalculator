using System;
using System.Collections.Generic;
using System.Text;
using TipCalculatorApp.Models;
using TipCalculatorApp.Repositories;

namespace TipCalculatorApp.Services
{
    public class TipService : ITipService
    {
        private ITipRepository tipRepository;

        public TipService(ITipRepository tipRepository)
        {
            this.tipRepository = tipRepository;
        }

        public List<Tip> GetTips()
        {
            return tipRepository.GetTips();
        }

        public List<Tip> SetTips(Tip newTip)
        {
            return tipRepository.AddTip(newTip);
        }
    }
}
