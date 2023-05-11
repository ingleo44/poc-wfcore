using System;
using System.Text.Json.Serialization;

namespace POC_RuleGenerator.model
{
    public class ItemsViewModel
    {

        public int? MaxOrderQuantity { get; set; }
        public string MinEnforced { get; set; }

        public string MaxEnforced { get; set; }

        public int? ReorderMultiple { get; set; }

        public int? MinOrderQuantity { get; set; }


        [JsonPropertyName("Id")]
        public int Id { get; set; }
        [JsonPropertyName("InternalId")]
        public string InternalId { get; set; }
        [JsonPropertyName("ParentID")]
        public string ParentID { get; set; }
        [JsonPropertyName("programId")]
        public int ProgramId { get; set; }
        [JsonPropertyName("categoryId")]
        public int CategoryId { get; set; }
        [JsonPropertyName("symbol")]
        public int symbol { get; set; }
        [JsonPropertyName("Name2")]
        public string Name2 { get; set; }
        [JsonPropertyName("Name")]
        public string Name { get; set; }
        [JsonPropertyName("Description")]
        public string Description { get; set; }
        [JsonPropertyName("purchaseDescription")]
        public string PurchaseDescription { get; set; }
        [JsonPropertyName("Inactive")]
        public string Inactive { get; set; }
        [JsonPropertyName("Discontinued 1")]
        public string Discontinued1 { get; set; }
        [JsonPropertyName("Preferred Vendor")]
        public string PreferredVendor { get; set; }
        [JsonPropertyName("universalProductType")]
        public string UniversalProductType { get; set; }
        [JsonPropertyName("Y1")]
        public int? Y1_Total { get; set; }
        [JsonPropertyName("Y0")]
        public int? Y0_Total { get; set; }
        [JsonPropertyName("Y2")]
        public int? Y2_Total { get; set; }
        [JsonPropertyName("Y3")]
        public int? Y3_Total { get; set; }
        [JsonPropertyName("L12M")]
        public int? L12M { get; set; }
        [JsonPropertyName("L3M")]
        public int? L3M { get; set; }
        [JsonPropertyName("poQtyModifier")]
        public int? POQtyModifer { get; set; } = 0;
        [JsonPropertyName("Avail Total")]
        public int? Avail_Total { get; set; }
        [JsonPropertyName("Notes")]
        public string Notes { get; set; }
        [JsonPropertyName("Vendor Notes")]
        public string VendorNotes { get; set; }
        [JsonPropertyName("PurchasingNotes")]
        public string PurchasingNotes { get; set; }
        [JsonPropertyName("Sales Notes")]
        public string SalesNotes { get; set; }
        [JsonPropertyName("Engineering Notes")]
        public string EngineeringNotes { get; set; }
        public string ItemComments { get; set; }
        public string Replaces { get; set; }
        public string ReplacedBy { get; set; }
        [JsonPropertyName("Purchase Price")]
        public double? PurchasePrice { get; set; }
        [JsonPropertyName("MT PO Qty")]
        public int? MTPOQty { get; set; }

        [JsonPropertyName("PO_Notes")]
        public string PO_Notes { get; set; }

        [JsonPropertyName("AC PO Qty")]
        public int? ACPOQty { get; set; }

        [JsonPropertyName("Active Parents")]
        public int? Active_Parents { get; set; }

        [JsonPropertyName("ActivePublic")]
        public int? ActivePublic { get; set; }

        [JsonPropertyName("ActiveNoPublic")]
        public int? ActiveNoPublic { get; set; }

        [JsonPropertyName("Unique Customer Count")]
        public int? UniqueCustomerCount => (US_cust == null ? 0 : US_cust) + (Intl_cust == null ? 0 : Intl_cust);

        [JsonPropertyName("Intl Customer Count")]
        public Nullable<System.Int32> Intl_cust { get; set; }

        [JsonPropertyName("US Customer Count")]
        public Nullable<System.Int32> US_cust { get; set; }

        [JsonPropertyName("Top Buyer Share")]
        public double? TopBuyerShare { get; set; }
        [JsonPropertyName("QoH Total")]
        public int? QoH_Total { get; set; }
        [JsonPropertyName("PO Total")]
        public int? PO_Total { get; set; }

        [JsonPropertyName("BO total")]
        public int? BO_total { get; set; }
        [JsonPropertyName("Inbound")]
        public string Inbound { get; set; }

        [JsonPropertyName("Mod")]
        public int? Mod { get; set; }

        [JsonPropertyName("Refinish")]
        public int? Refinish { get; set; }
        [JsonPropertyName("ScrDent")]
        public int? ScrDent { get; set; }
        [JsonPropertyName("LJL Inventory")]
        public int? LJLInventory { get; set; }
        [JsonPropertyName("CostReviewer")]
        public double? CostReviewer { get; set; }



        [JsonPropertyName("CostMarket")]
        public double? CostMarket { get; set; }

        [JsonPropertyName("CostApprover")]
        public double? CostApprover { get; set; }


        [JsonPropertyName("QoHCA")]
        public int? QoH_CA { get; set; }

        [JsonPropertyName("QoHNC")]
        public int? QoH_NC { get; set; }

        [JsonPropertyName("AvailCA")]
        public int? Avail_CA { get; set; }

        [JsonPropertyName("AvailNC")]
        public int? Avail_NC { get; set; }

        [JsonPropertyName("CommitTotal")]
        public int? Commit_Total { get; set; }

        [JsonPropertyName("poQtyReviewer")]
        public int? PoQtyReviewer { get; set; }
        [JsonPropertyName("poNotesReviewer")]
        public string? PoNotesReviewer { get; set; }
        [JsonPropertyName("poQtyMarket")]
        public int? PoQtyMarket { get; set; }
        [JsonPropertyName("poNotesMarket")]
        public string? PoNotesMarket { get; set; }
        [JsonPropertyName("poQtyApprover")]
        public int? PoQtyApprover { get; set; }
        [JsonPropertyName("poNotesApprover")]
        public string? PoNotesApprover { get; set; }

        // Calculated Fields
        [JsonPropertyName("Avail + PO + Mod - BO")]
        public int? ATPTBT { get; set; }
        [JsonPropertyName("Y_Total")]
        public string Y_Total { get; set; }
        [JsonPropertyName("Remaining Est MoH L12M")]
        public string? RemainingEstMoHL12M { get; set; }
        [JsonPropertyName("L12MAvg")]
        public double? L12MAvg { get; set; }
        [JsonPropertyName("L3M vs L12M")]
        public double? L3MvsL12M { get; set; }
        [JsonPropertyName("L3M Avg")]
        public double? L3MAvg { get; set; }
        [JsonPropertyName("Remaining Est MoH L3M")]
        public string? RemainingEstMoHL3M { get; set; }

        [JsonPropertyName("Group Notes")]
        public string GroupNotes { get; set; }
        public bool HasPurchaseRestrictions { get; set; }




        // pending calculation



        //This field is calculated with the MoH target so it is affected by the settings
        [JsonPropertyName("Suggested PO Qty")]
        public int? SuggestedPOQty { get; set; }
        //This field is calculated with the Suggested so it is affected by the settings
        [JsonPropertyName("Revised PO Qty")]
        public int? RevisedPoQty { get; set; }
        [JsonPropertyName("Target MoH")]
        public int? TargetMoH { get; set; }
        // This field is calculated with the settings
        [JsonPropertyName("Mid MoH")]
        public int? MidEstQtyDefecit { get; set; }
        // This field is calculated with the settings
        [JsonPropertyName("Low MoH")]
        public int? LowEstQtyDefecit { get; set; }
        // This field combines the three previous columns so it is affected by the setting
        [JsonPropertyName("Defecit")]
        public string Defecit { get; set; }
        //This field is calculated with the MoH target so it is affected by the settings
        [JsonPropertyName("CostSuggested")]
        public double? CostSuggested { get; set; }


        //This field is calculated with the Suggested so it is affected by the settings
        [JsonPropertyName("CostRevised")]
        public double? CostRevised { get; set; }
        // This field depends on the Revised PO QTY
        [JsonPropertyName("Projected MoH after PO L12M")]
        public string? ProjectedMoHafterPol12M { get; set; }
        // This field depends on the Revised PO QTY
        [JsonPropertyName("Projected MoH after PO L3M")]
        public string ProjectedMoHafterPOL3M { get; set; }
        [JsonPropertyName("BaseItem")]
        public string BaseItem { get; set; }

        [JsonPropertyName("additionalMohL3ML12MLoad")]
        public string? AdditionalL3Ml12MLoad { get; set; }

        [JsonPropertyName("UpdatedDate")]
        public DateTime? UpdatedDate { get; set; }
        [JsonPropertyName("LastUpdate")]
        public int? LastUpdate { get; set; }
    }
}