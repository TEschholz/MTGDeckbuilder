using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTGDeckbuilder.MtgJsonObjects
{
    public class Card
    {
        public string Artist { get; set; }
        public string BorderColor { get; set; }
        public IList<string> ColorIdentity { get; set; }
        public IList<string> Colors { get; set; }
        public double ConvertedManaCost { get; set; }
        public int EdhrecRank { get; set; }
        public IList<ForeignData> ForeignData { get; set; }
        public string FrameVersion { get; set; }
        public bool HasFoil { get; set; }
        public bool HasNonFoil { get; set; }
        public bool IsMtgo { get; set; }
        public bool IsPaper { get; set; }
        public bool IsReprint { get; set; }
        public string Layout { get; set; }
        public Legalities Legalities { get; set; }
        public string ManaCost { get; set; }
        public int McmId { get; set; }
        public int McmMetaId { get; set; }
        public int MtgoFoilId { get; set; }
        public int MtgoId { get; set; }
        public int MultiverseId { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public string OriginalText { get; set; }
        public string OriginalType { get; set; }
        public Prices Prices { get; set; }
        public IList<string> Printings { get; set; }
        public PurchaseUrls PurchaseUrls { get; set; }
        public string Rarity { get; set; }
        public IList<Ruling> Rulings { get; set; }
        public string ScryfallId { get; set; }
        public string ScryfallIllustrationId { get; set; }
        public string ScryfallOracleId { get; set; }
        public IList<object> Subtypes { get; set; }
        public IList<object> Supertypes { get; set; }
        public int TcgplayerProductId { get; set; }
        public string Text { get; set; }
        public string Type { get; set; }
        public IList<string> Types { get; set; }
        public string Uuid { get; set; }

    }
}
