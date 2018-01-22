namespace Models.ES 
{
	public class StaffDepartmentLevel
{
			public int Id {get; set;} 
		public string Uid {get; set;} 
		public string LevelUid {get; set;} 
		public string DepartmentUid {get; set;} 
		public string Name {get; set;} 
		public string Description {get; set;} 
		public int IsActive {get; set;} 
		public int IsDelete {get; set;} 
		public int CreateTime {get; set;} 
		public int ModifyTime {get; set;} 
		public TimeSpan CreateAt {get; set;} 
		public TimeSpan ModifyAt {get; set;} 

}
}