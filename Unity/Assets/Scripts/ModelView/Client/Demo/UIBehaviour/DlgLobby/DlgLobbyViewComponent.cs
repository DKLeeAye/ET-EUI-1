
using UnityEngine;
using UnityEngine.UI;
namespace ET.Client
{
	[ComponentOf(typeof(DlgLobby))]
	[EnableMethod]
	public  class DlgLobbyViewComponent : Entity,IAwake,IDestroy 
	{
		public UnityEngine.RectTransform EGBackGroundRectTransform
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EGBackGroundRectTransform == null )
     			{
		    		this.m_EGBackGroundRectTransform = UIFindHelper.FindDeepChild<UnityEngine.RectTransform>(this.uiTransform.gameObject,"EGBackGround");
     			}
     			return this.m_EGBackGroundRectTransform;
     		}
     	}

		public UnityEngine.UI.Button E_PlayButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_PlayButton == null )
     			{
		    		this.m_E_PlayButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"EGBackGround/Top/E_Play");
     			}
     			return this.m_E_PlayButton;
     		}
     	}

		public UnityEngine.UI.Image E_PlayImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_PlayImage == null )
     			{
		    		this.m_E_PlayImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EGBackGround/Top/E_Play");
     			}
     			return this.m_E_PlayImage;
     		}
     	}

		public UnityEngine.UI.Button E_MatchingButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_MatchingButton == null )
     			{
		    		this.m_E_MatchingButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"EGBackGround/Top/E_Matching");
     			}
     			return this.m_E_MatchingButton;
     		}
     	}

		public UnityEngine.UI.Image E_MatchingImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_MatchingImage == null )
     			{
		    		this.m_E_MatchingImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EGBackGround/Top/E_Matching");
     			}
     			return this.m_E_MatchingImage;
     		}
     	}

		public UnityEngine.RectTransform EG_MidRectTransform
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EG_MidRectTransform == null )
     			{
		    		this.m_EG_MidRectTransform = UIFindHelper.FindDeepChild<UnityEngine.RectTransform>(this.uiTransform.gameObject,"EGBackGround/EG_Mid");
     			}
     			return this.m_EG_MidRectTransform;
     		}
     	}

		public UnityEngine.UI.Button E_NormalButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_NormalButton == null )
     			{
		    		this.m_E_NormalButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"EGBackGround/EG_Mid/E_Normal");
     			}
     			return this.m_E_NormalButton;
     		}
     	}

		public UnityEngine.UI.Image E_NormalImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_NormalImage == null )
     			{
		    		this.m_E_NormalImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EGBackGround/EG_Mid/E_Normal");
     			}
     			return this.m_E_NormalImage;
     		}
     	}

		public UnityEngine.RectTransform EGDecksRectTransform
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EGDecksRectTransform == null )
     			{
		    		this.m_EGDecksRectTransform = UIFindHelper.FindDeepChild<UnityEngine.RectTransform>(this.uiTransform.gameObject,"EGBackGround/EGDecks");
     			}
     			return this.m_EGDecksRectTransform;
     		}
     	}

		public UnityEngine.UI.Image EDeckListImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EDeckListImage == null )
     			{
		    		this.m_EDeckListImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EGBackGround/EGDecks/EDeckList");
     			}
     			return this.m_EDeckListImage;
     		}
     	}

		public UnityEngine.UI.LoopVerticalScrollRect EDeckListLoopVerticalScrollRect
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EDeckListLoopVerticalScrollRect == null )
     			{
		    		this.m_EDeckListLoopVerticalScrollRect = UIFindHelper.FindDeepChild<UnityEngine.UI.LoopVerticalScrollRect>(this.uiTransform.gameObject,"EGBackGround/EGDecks/EDeckList");
     			}
     			return this.m_EDeckListLoopVerticalScrollRect;
     		}
     	}

		public UnityEngine.UI.Button EMatchButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EMatchButton == null )
     			{
		    		this.m_EMatchButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"EGBackGround/EGDecks/EMatch");
     			}
     			return this.m_EMatchButton;
     		}
     	}

		public UnityEngine.UI.Image EMatchImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EMatchImage == null )
     			{
		    		this.m_EMatchImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EGBackGround/EGDecks/EMatch");
     			}
     			return this.m_EMatchImage;
     		}
     	}

		public UnityEngine.UI.Button EBackButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EBackButton == null )
     			{
		    		this.m_EBackButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"EGBackGround/EGDecks/EBack");
     			}
     			return this.m_EBackButton;
     		}
     	}

		public UnityEngine.UI.Image EBackImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EBackImage == null )
     			{
		    		this.m_EBackImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EGBackGround/EGDecks/EBack");
     			}
     			return this.m_EBackImage;
     		}
     	}

		public UnityEngine.UI.Button E_EnterMapButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_EnterMapButton == null )
     			{
		    		this.m_E_EnterMapButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_EnterMap");
     			}
     			return this.m_E_EnterMapButton;
     		}
     	}

		public UnityEngine.UI.Image E_EnterMapImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_EnterMapImage == null )
     			{
		    		this.m_E_EnterMapImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_EnterMap");
     			}
     			return this.m_E_EnterMapImage;
     		}
     	}

		public void DestroyWidget()
		{
			this.m_EGBackGroundRectTransform = null;
			this.m_E_PlayButton = null;
			this.m_E_PlayImage = null;
			this.m_E_MatchingButton = null;
			this.m_E_MatchingImage = null;
			this.m_EG_MidRectTransform = null;
			this.m_E_NormalButton = null;
			this.m_E_NormalImage = null;
			this.m_EGDecksRectTransform = null;
			this.m_EDeckListImage = null;
			this.m_EDeckListLoopVerticalScrollRect = null;
			this.m_EMatchButton = null;
			this.m_EMatchImage = null;
			this.m_EBackButton = null;
			this.m_EBackImage = null;
			this.m_E_EnterMapButton = null;
			this.m_E_EnterMapImage = null;
			this.uiTransform = null;
		}

		private UnityEngine.RectTransform m_EGBackGroundRectTransform = null;
		private UnityEngine.UI.Button m_E_PlayButton = null;
		private UnityEngine.UI.Image m_E_PlayImage = null;
		private UnityEngine.UI.Button m_E_MatchingButton = null;
		private UnityEngine.UI.Image m_E_MatchingImage = null;
		private UnityEngine.RectTransform m_EG_MidRectTransform = null;
		private UnityEngine.UI.Button m_E_NormalButton = null;
		private UnityEngine.UI.Image m_E_NormalImage = null;
		private UnityEngine.RectTransform m_EGDecksRectTransform = null;
		private UnityEngine.UI.Image m_EDeckListImage = null;
		private UnityEngine.UI.LoopVerticalScrollRect m_EDeckListLoopVerticalScrollRect = null;
		private UnityEngine.UI.Button m_EMatchButton = null;
		private UnityEngine.UI.Image m_EMatchImage = null;
		private UnityEngine.UI.Button m_EBackButton = null;
		private UnityEngine.UI.Image m_EBackImage = null;
		private UnityEngine.UI.Button m_E_EnterMapButton = null;
		private UnityEngine.UI.Image m_E_EnterMapImage = null;
		public Transform uiTransform = null;
	}
}
