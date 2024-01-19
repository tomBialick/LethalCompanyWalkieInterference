using GameNetcodeStuff;
using HarmonyLib;
using UnityEngine;
using LC_API.BundleAPI;

namespace LCWalkieInterferenceMod.Patches;

[HarmonyPatch(typeof(StartOfRound))]
internal class StartOfRoundPatch
{
    //AudioClip clip = new AudioClip();
    //public AudioClip radioStaticAudioClip;

    [HarmonyPatch("UpdatePlayerVoiceEffects")]
    [HarmonyPrefix]
    static void noisyPlayerVoiceEffectsPatch()
    {
        //currentVoiceChatAudioSource.
        //SoundManager
        // AudioClip radioStaticAudioClip = BundleLoader.GetLoadedAsset<AudioClip>("Assets/AssetBundles/radio_static.wav");
        //radioStaticAudioClip = clip;
        // Plugin.Log.LogInfo("Loaded Audio Clip for Asset Bundle:");
        // Plugin.Log.LogInfo(radioStaticAudioClip);
        
        // currentVoiceChatAudioSource.clip = Plugin.radioStaticAudioClip;
        // AudioSource currentVoiceChatAudioSource = allPlayerScripts[i].currentVoiceChatAudioSource;

        // for (int i = 0; i < allPlayerScripts.Length; i++)
        // {

        // }

        //if (GameNetworkManager.Instance == null || GameNetworkManager.Instance.localPlayerController == null)
        //{
        //    return;
        //}
        //updatePlayerVoiceInterval = 2f;
        //PlayerControllerB playerControllerB = ((!GameNetworkManager.Instance.localPlayerController.isPlayerDead || !(GameNetworkManager.Instance.localPlayerController.spectatedPlayerScript != null)) ? GameNetworkManager.Instance.localPlayerController : GameNetworkManager.Instance.localPlayerController.spectatedPlayerScript);
        //for (int i = 0; i < allPlayerScripts.Length; i++)
        //{
        //    PlayerControllerB playerControllerB2 = allPlayerScripts[i];
        //    if ((!playerControllerB2.isPlayerControlled && !playerControllerB2.isPlayerDead) || playerControllerB2 == GameNetworkManager.Instance.localPlayerController)
        //    {
        //        continue;
        //    }
        //    if (playerControllerB2.voicePlayerState == null || playerControllerB2.currentVoiceChatIngameSettings._playerState == null || playerControllerB2.currentVoiceChatAudioSource == null)
        //    {
        //        RefreshPlayerVoicePlaybackObjects();
        //        if (playerControllerB2.voicePlayerState == null || playerControllerB2.currentVoiceChatAudioSource == null)
        //        {
        //            Debug.Log($"Was not able to access voice chat object for player #{i}; {playerControllerB2.voicePlayerState == null}; {playerControllerB2.currentVoiceChatAudioSource == null}");
        //            continue;
        //        }
        //    }
        //    AudioSource currentVoiceChatAudioSource = allPlayerScripts[i].currentVoiceChatAudioSource;
        //    bool flag = playerControllerB2.speakingToWalkieTalkie && playerControllerB.holdingWalkieTalkie && playerControllerB2 != playerControllerB;
        //    if (playerControllerB2.isPlayerDead)
        //    {
        //        currentVoiceChatAudioSource.GetComponent<AudioLowPassFilter>().enabled = false;
        //        currentVoiceChatAudioSource.GetComponent<AudioHighPassFilter>().enabled = false;
        //        currentVoiceChatAudioSource.panStereo = 0f;
        //        SoundManager.Instance.playerVoicePitchTargets[playerControllerB2.playerClientId] = 1f;
        //        SoundManager.Instance.SetPlayerPitch(1f, (int)playerControllerB2.playerClientId);
        //        if (GameNetworkManager.Instance.localPlayerController.isPlayerDead)
        //        {
        //            currentVoiceChatAudioSource.spatialBlend = 0f;
        //            playerControllerB2.currentVoiceChatIngameSettings.set2D = true;
        //            playerControllerB2.voicePlayerState.Volume = 1f;
        //        }
        //        else
        //        {
        //            currentVoiceChatAudioSource.spatialBlend = 1f;
        //            playerControllerB2.currentVoiceChatIngameSettings.set2D = false;
        //            playerControllerB2.voicePlayerState.Volume = 0f;
        //        }
        //        continue;
        //    }
        //    AudioLowPassFilter component = currentVoiceChatAudioSource.GetComponent<AudioLowPassFilter>();
        //    OccludeAudio component2 = currentVoiceChatAudioSource.GetComponent<OccludeAudio>();
        //    component.enabled = true;
        //    component2.overridingLowPass = flag || allPlayerScripts[i].voiceMuffledByEnemy;
        //    currentVoiceChatAudioSource.GetComponent<AudioHighPassFilter>().enabled = flag;
        //    if (!flag)
        //    {
        //        currentVoiceChatAudioSource.spatialBlend = 1f;
        //        playerControllerB2.currentVoiceChatIngameSettings.set2D = false;
        //        currentVoiceChatAudioSource.bypassListenerEffects = false;
        //        currentVoiceChatAudioSource.bypassEffects = false;
        //        currentVoiceChatAudioSource.outputAudioMixerGroup = SoundManager.Instance.playerVoiceMixers[playerControllerB2.playerClientId];
        //        component.lowpassResonanceQ = 1f;
        //    }
        //    else
        //    {
        //        currentVoiceChatAudioSource.spatialBlend = 0f;
        //        playerControllerB2.currentVoiceChatIngameSettings.set2D = true;
        //        if (GameNetworkManager.Instance.localPlayerController.isPlayerDead)
        //        {
        //            currentVoiceChatAudioSource.panStereo = 0f;
        //            currentVoiceChatAudioSource.outputAudioMixerGroup = SoundManager.Instance.playerVoiceMixers[playerControllerB2.playerClientId];
        //            currentVoiceChatAudioSource.bypassListenerEffects = false;
        //            currentVoiceChatAudioSource.bypassEffects = false;
        //        }
        //        else
        //        {
        //            currentVoiceChatAudioSource.panStereo = 0.4f;
        //            currentVoiceChatAudioSource.bypassListenerEffects = false;
        //            currentVoiceChatAudioSource.bypassEffects = false;
        //            currentVoiceChatAudioSource.outputAudioMixerGroup = SoundManager.Instance.playerVoiceMixers[playerControllerB2.playerClientId];
        //        }
        //        component2.lowPassOverride = 4000f;
        //        component.lowpassResonanceQ = 3f;
        //    }
        //    if (GameNetworkManager.Instance.localPlayerController.isPlayerDead)
        //    {
        //        playerControllerB2.voicePlayerState.Volume = 0.8f;
        //    }
        //    else
        //    {
        //        playerControllerB2.voicePlayerState.Volume = 1f;
        //    }
        //}

    }
}

// Original Method for Reference
/*
public void UpdatePlayerVoiceEffects()
{
    if (GameNetworkManager.Instance == null || GameNetworkManager.Instance.localPlayerController == null)
    {
        return;
    }
    updatePlayerVoiceInterval = 2f;
    PlayerControllerB playerControllerB = ((!GameNetworkManager.Instance.localPlayerController.isPlayerDead || !(GameNetworkManager.Instance.localPlayerController.spectatedPlayerScript != null)) ? GameNetworkManager.Instance.localPlayerController : GameNetworkManager.Instance.localPlayerController.spectatedPlayerScript);
    for (int i = 0; i < allPlayerScripts.Length; i++)
    {
        PlayerControllerB playerControllerB2 = allPlayerScripts[i];
        if ((!playerControllerB2.isPlayerControlled && !playerControllerB2.isPlayerDead) || playerControllerB2 == GameNetworkManager.Instance.localPlayerController)
        {
            continue;
        }
        if (playerControllerB2.voicePlayerState == null || playerControllerB2.currentVoiceChatIngameSettings._playerState == null || playerControllerB2.currentVoiceChatAudioSource == null)
        {
            RefreshPlayerVoicePlaybackObjects();
            if (playerControllerB2.voicePlayerState == null || playerControllerB2.currentVoiceChatAudioSource == null)
            {
                Debug.Log($"Was not able to access voice chat object for player #{i}; {playerControllerB2.voicePlayerState == null}; {playerControllerB2.currentVoiceChatAudioSource == null}");
                continue;
            }
        }
        AudioSource currentVoiceChatAudioSource = allPlayerScripts[i].currentVoiceChatAudioSource;
        bool flag = playerControllerB2.speakingToWalkieTalkie && playerControllerB.holdingWalkieTalkie && playerControllerB2 != playerControllerB;
        if (playerControllerB2.isPlayerDead)
        {
            currentVoiceChatAudioSource.GetComponent<AudioLowPassFilter>().enabled = false;
            currentVoiceChatAudioSource.GetComponent<AudioHighPassFilter>().enabled = false;
            currentVoiceChatAudioSource.panStereo = 0f;
            SoundManager.Instance.playerVoicePitchTargets[playerControllerB2.playerClientId] = 1f;
            SoundManager.Instance.SetPlayerPitch(1f, (int)playerControllerB2.playerClientId);
            if (GameNetworkManager.Instance.localPlayerController.isPlayerDead)
            {
                currentVoiceChatAudioSource.spatialBlend = 0f;
                playerControllerB2.currentVoiceChatIngameSettings.set2D = true;
                playerControllerB2.voicePlayerState.Volume = 1f;
            }
            else
            {
                currentVoiceChatAudioSource.spatialBlend = 1f;
                playerControllerB2.currentVoiceChatIngameSettings.set2D = false;
                playerControllerB2.voicePlayerState.Volume = 0f;
            }
            continue;
        }
        AudioLowPassFilter component = currentVoiceChatAudioSource.GetComponent<AudioLowPassFilter>();
        OccludeAudio component2 = currentVoiceChatAudioSource.GetComponent<OccludeAudio>();
        component.enabled = true;
        component2.overridingLowPass = flag || allPlayerScripts[i].voiceMuffledByEnemy;
        currentVoiceChatAudioSource.GetComponent<AudioHighPassFilter>().enabled = flag;
        if (!flag)
        {
            currentVoiceChatAudioSource.spatialBlend = 1f;
            playerControllerB2.currentVoiceChatIngameSettings.set2D = false;
            currentVoiceChatAudioSource.bypassListenerEffects = false;
            currentVoiceChatAudioSource.bypassEffects = false;
            currentVoiceChatAudioSource.outputAudioMixerGroup = SoundManager.Instance.playerVoiceMixers[playerControllerB2.playerClientId];
            component.lowpassResonanceQ = 1f;
        }
        else
        {
            currentVoiceChatAudioSource.spatialBlend = 0f;
            playerControllerB2.currentVoiceChatIngameSettings.set2D = true;
            if (GameNetworkManager.Instance.localPlayerController.isPlayerDead)
            {
                currentVoiceChatAudioSource.panStereo = 0f;
                currentVoiceChatAudioSource.outputAudioMixerGroup = SoundManager.Instance.playerVoiceMixers[playerControllerB2.playerClientId];
                currentVoiceChatAudioSource.bypassListenerEffects = false;
                currentVoiceChatAudioSource.bypassEffects = false;
            }
            else
            {
                currentVoiceChatAudioSource.panStereo = 0.4f;
                currentVoiceChatAudioSource.bypassListenerEffects = false;
                currentVoiceChatAudioSource.bypassEffects = false;
                currentVoiceChatAudioSource.outputAudioMixerGroup = SoundManager.Instance.playerVoiceMixers[playerControllerB2.playerClientId];
            }
            component2.lowPassOverride = 4000f;
            component.lowpassResonanceQ = 3f;
        }
        if (GameNetworkManager.Instance.localPlayerController.isPlayerDead)
        {
            playerControllerB2.voicePlayerState.Volume = 0.8f;
        }
        else
        {
            playerControllerB2.voicePlayerState.Volume = 1f;
        }
    }
}
*/