﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic
{
    public class Result
    {
        public Player Winner { get; set; }
        public EndReason Reason { get; set; }    
        public Result(Player winner, EndReason reason) 
        { 
            Winner = winner;
            Reason = reason;
        }

        public static Result win(Player winner)
        {
            return new Result(winner, EndReason.CheckMate);
        }

        public static Result Draw(EndReason reason)
        {
            return new Result(Player.None, reason);
        }

    }
}
