﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Data.Domain.Entities
{
    public class StockRecord
    {
        private StockRecord()
        {

        }

        public Guid Id { get; private set; }

        public DateTime Date { get; private set; }

        [Range(1, double.MaxValue)]
        public Double StartPrice { get; private set; }

        [Range(1, double.MaxValue)]
        public Double EndPrice { get; private set; }

        [StringLength(30)]
        public String Owner { get; private set; }

        public static StockRecord Create(DateTime date, Double startPrice, Double endPrice, String owner)
        {
            var instance = new StockRecord { Id = new Guid() };

            instance.Update(date, startPrice, endPrice, owner);

            return instance;

        }

        public void Update(DateTime date, Double startPrice, Double endPrice, String owner)
        {
            Date = date;
            StartPrice = startPrice;
            EndPrice = endPrice;
            Owner = owner;
        }
    }
}