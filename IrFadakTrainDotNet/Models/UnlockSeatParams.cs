﻿using System;
using System.Collections.Generic;
using System.Text;

namespace IrFadakTrainDotNet.Models
{
   public class UnlockSeatParams
    {
        public long SaleId { get; set; }
        public int TrainNumber { get; set; }
        public DateTime MoveDate { get; set; }
    }
}
