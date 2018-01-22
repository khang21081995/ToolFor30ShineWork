using Nest;

namespace API30Shine.Models.ESModels 
{
	public class PrdProductGroupES : ThirtyShine.Conductor.Common.ElasticSearch.EsBaseModel
	{

		[Text(Name="id")]
		public int Id {get; set;} 

		[Text(Name="uid")]
		public string Uid {get; set;} 

		[Text(Name="prd_group_uid")]
		public string PrdGroupUid {get; set;} 

		[Text(Name="prd_product_uid")]
		public string PrdProductUid {get; set;} 

		[Text(Name="order_number")]
		public int OrderNumber {get; set;} 

		[Text(Name="is_active")]
		public int IsActive {get; set;} 

		[Text(Name="is_delete")]
		public int IsDelete {get; set;} 

		[Text(Name="create_at")]
		public TimeSpan CreateAt {get; set;} 

		[Text(Name="modify_at")]
		public TimeSpan ModifyAt {get; set;} 

		[Text(Name="create_time")]
		public int CreateTime {get; set;} 

		[Text(Name="modify_time")]
		public int ModifyTime {get; set;} 

	}
}