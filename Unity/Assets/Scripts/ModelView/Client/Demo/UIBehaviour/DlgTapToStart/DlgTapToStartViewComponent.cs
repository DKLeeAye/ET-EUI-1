
using UnityEngine;
using UnityEngine.UI;
namespace ET.Client
{
	[ComponentOf(typeof(DlgTapToStart))]
	[EnableMethod]
	public  class DlgTapToStartViewComponent : Entity,IAwake,IDestroy 
	{
		public UnityEngine.UI.Button E_StartButtonButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_StartButtonButton == null )
     			{
		    		this.m_E_StartButtonButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"TapToStart/E_StartButton");
     			}
     			return this.m_E_StartButtonButton;
     		}
     	}

		public UnityEngine.UI.Image E_StartButtonImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_StartButtonImage == null )
     			{
		    		this.m_E_StartButtonImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"TapToStart/E_StartButton");
     			}
     			return this.m_E_StartButtonImage;
     		}
     	}

		public void DestroyWidget()
		{
			this.m_E_StartButtonButton = null;
			this.m_E_StartButtonImage = null;
			this.uiTransform = null;
		}

		private UnityEngine.UI.Button m_E_StartButtonButton = null;
		private UnityEngine.UI.Image m_E_StartButtonImage = null;
		public Transform uiTransform = null;
	}
}
