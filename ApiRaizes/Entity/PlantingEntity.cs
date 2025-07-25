﻿namespace ApiRaizes.Entity
{
    public class PlantingEntity
    {
        public int Id { get; set; }
        public int EspecieId { get; set; }
        public int PropriedadeId { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public decimal AreaPlantada { get; set; }
        public int Mudas { get; set; }
        public string Descricao { get; set; }
        public int UnidadeMedidaId { get; set; }
    }
}
