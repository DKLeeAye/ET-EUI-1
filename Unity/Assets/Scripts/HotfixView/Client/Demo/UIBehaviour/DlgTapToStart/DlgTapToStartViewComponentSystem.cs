
using UnityEngine;
using UnityEngine.UI;
namespace ET.Client
{
	[EntitySystemOf(typeof(DlgTapToStartViewComponent))]
	[FriendOfAttribute(typeof(ET.Client.DlgTapToStartViewComponent))]
	public static partial class DlgTapToStartViewComponentSystem
	{
		[EntitySystem]
		private static void Awake(this DlgTapToStartViewComponent self)
		{
			self.uiTransform = self.Parent.GetParent<UIBaseWindow>().uiTransform;
		}


		[EntitySystem]
		private static void Destroy(this DlgTapToStartViewComponent self)
		{
			self.DestroyWidget();
		}
	}


}
