﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boardgames.Data.Models
{
    public class BoardgameSeller
    {
        public int BoardgameId { get; set; }
        [ForeignKey(nameof(BoardgameId))]
        public virtual Boardgame Boardgame { get; set; } = null!;

        public int SellerId { get; set; }
        [ForeignKey(nameof(SellerId))]
        public virtual Seller Seller { get; set; } = null!;
    }
}
