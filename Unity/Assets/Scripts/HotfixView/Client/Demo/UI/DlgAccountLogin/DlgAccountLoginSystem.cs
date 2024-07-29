using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using System.Net;

namespace ET.Client
{
	[FriendOf(typeof(DlgAccountLogin))]
	public static  class DlgAccountLoginSystem
	{

		public static void RegisterUIEvent(this DlgAccountLogin self)
		{
            //self.View.E_BtnLoginButton.AddListenerAsync(self.Root(), self.OnLoginButtonClickHandler);
        }

		public static void ShowWindow(this DlgAccountLogin self, Entity contextData = null)
		{
		}

    }
}
