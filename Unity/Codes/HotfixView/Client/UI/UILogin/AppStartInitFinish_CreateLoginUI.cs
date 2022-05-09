﻿namespace ET.Client
{
	[Event(SceneType.Zone)]
	public class AppStartInitFinish_CreateLoginUI: AEvent<Scene, EventType.AppStartInitFinish>
	{
		protected override async ETTask Run(Scene scene, EventType.AppStartInitFinish args)
		{
			await UIHelper.Create(scene, UIType.UILogin, UILayer.Mid);
		}
	}
}