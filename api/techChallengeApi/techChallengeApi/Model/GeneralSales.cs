namespace techChallengeApi.Model
{
    public class GeneralSales 
    {
        public int Id { get; set; }
        public int? VarietyId { get; set; }
        public Variety Variety { get; set; }
        public DateTime Date { get; set; }
        public int? ProductId { get; set; }
        public Products Product { get; set; }
        public int Value { get; set; }
        public int? SellerId { get; set; }
        public Seller Seller { get; set; }

    }
}
