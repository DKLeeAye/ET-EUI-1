using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET.Client
{
	[FriendOf(typeof(DlgTapToStart))]
	public static  class DlgTapToStartSystem
	{

		public static void RegisterUIEvent(this DlgTapToStart self)
		{
            self.View.E_StartButtonButton.AddListenerAsync(self.Root(),self.OnStartClickHandler);
        }

		public static void ShowWindow(this DlgTapToStart self, Entity contextData = null)
		{

		}

        public static async ETTask OnStartClickHandler(this DlgTapToStart self)
        {
            self.Root().GetComponent<UIComponent>().ShowWindow(WindowID.WindowID_AccountLogin);

            await ETTask.CompletedTask;
        }


    }
}
