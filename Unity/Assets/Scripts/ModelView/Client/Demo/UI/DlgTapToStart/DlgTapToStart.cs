namespace ET.Client
{
	 [ComponentOf(typeof(UIBaseWindow))]
	public  class DlgTapToStart :Entity,IAwake,IUILogic
	{

		public DlgTapToStartViewComponent View { get => this.GetComponent<DlgTapToStartViewComponent>();} 

		 

	}
}
