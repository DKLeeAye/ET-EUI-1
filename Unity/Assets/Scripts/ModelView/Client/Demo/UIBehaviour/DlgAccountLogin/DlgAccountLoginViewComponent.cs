
using UnityEngine;
using UnityEngine.UI;
namespace ET.Client
{
	[ComponentOf(typeof(DlgAccountLogin))]
	[EnableMethod]
	public  class DlgAccountLoginViewComponent : Entity,IAwake,IDestroy 
	{
		public UnityEngine.UI.Button E_BtnLoginButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_BtnLoginButton == null )
     			{
		    		this.m_E_BtnLoginButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"Popup_Login/Popup/E_BtnLogin");
     			}
     			return this.m_E_BtnLoginButton;
     		}
     	}

		public UnityEngine.UI.Image E_BtnLoginImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_BtnLoginImage == null )
     			{
		    		this.m_E_BtnLoginImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Popup_Login/Popup/E_BtnLogin");
     			}
     			return this.m_E_BtnLoginImage;
     		}
     	}

		public TMPro.TMP_InputField E_AccountInputFieldTMP_InputField
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_AccountInputFieldTMP_InputField == null )
     			{
		    		this.m_E_AccountInputFieldTMP_InputField = UIFindHelper.FindDeepChild<TMPro.TMP_InputField>(this.uiTransform.gameObject,"Popup_Login/Popup/InputFields/E_AccountInputField");
     			}
     			return this.m_E_AccountInputFieldTMP_InputField;
     		}
     	}

		public UnityEngine.UI.Image E_AccountInputFieldImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_AccountInputFieldImage == null )
     			{
		    		this.m_E_AccountInputFieldImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Popup_Login/Popup/InputFields/E_AccountInputField");
     			}
     			return this.m_E_AccountInputFieldImage;
     		}
     	}

		public TMPro.TMP_InputField E_PasswordInputFieldTMP_InputField
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_PasswordInputFieldTMP_InputField == null )
     			{
		    		this.m_E_PasswordInputFieldTMP_InputField = UIFindHelper.FindDeepChild<TMPro.TMP_InputField>(this.uiTransform.gameObject,"Popup_Login/Popup/InputFields/E_PasswordInputField");
     			}
     			return this.m_E_PasswordInputFieldTMP_InputField;
     		}
     	}

		public UnityEngine.UI.Image E_PasswordInputFieldImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_PasswordInputFieldImage == null )
     			{
		    		this.m_E_PasswordInputFieldImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Popup_Login/Popup/InputFields/E_PasswordInputField");
     			}
     			return this.m_E_PasswordInputFieldImage;
     		}
     	}

		public UnityEngine.UI.Dropdown E_ServerAddressDropdown
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_ServerAddressDropdown == null )
     			{
		    		this.m_E_ServerAddressDropdown = UIFindHelper.FindDeepChild<UnityEngine.UI.Dropdown>(this.uiTransform.gameObject,"Popup_Login/Popup/E_ServerAddress");
     			}
     			return this.m_E_ServerAddressDropdown;
     		}
     	}

		public UnityEngine.UI.Image E_ServerAddressImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_ServerAddressImage == null )
     			{
		    		this.m_E_ServerAddressImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Popup_Login/Popup/E_ServerAddress");
     			}
     			return this.m_E_ServerAddressImage;
     		}
     	}

		public void DestroyWidget()
		{
			this.m_E_BtnLoginButton = null;
			this.m_E_BtnLoginImage = null;
			this.m_E_AccountInputFieldTMP_InputField = null;
			this.m_E_AccountInputFieldImage = null;
			this.m_E_PasswordInputFieldTMP_InputField = null;
			this.m_E_PasswordInputFieldImage = null;
			this.m_E_ServerAddressDropdown = null;
			this.m_E_ServerAddressImage = null;
			this.uiTransform = null;
		}

		private UnityEngine.UI.Button m_E_BtnLoginButton = null;
		private UnityEngine.UI.Image m_E_BtnLoginImage = null;
		private TMPro.TMP_InputField m_E_AccountInputFieldTMP_InputField = null;
		private UnityEngine.UI.Image m_E_AccountInputFieldImage = null;
		private TMPro.TMP_InputField m_E_PasswordInputFieldTMP_InputField = null;
		private UnityEngine.UI.Image m_E_PasswordInputFieldImage = null;
		private UnityEngine.UI.Dropdown m_E_ServerAddressDropdown = null;
		private UnityEngine.UI.Image m_E_ServerAddressImage = null;
		public Transform uiTransform = null;
	}
}
