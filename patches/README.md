## Relevant Methods in LC Binary

### WalkieTalkie
`private void BroadcastSFXFromWalkieTalkie(AudioClip sfx, int fromPlayerId)`

`private void PlayerHoldingWalkieTalkieButton(bool speaking)`

`public static void TransmitOneShotAudio(AudioSource audioSource, AudioClip clip, float vol = 1f)`

`private void SendWalkieTalkieStartTransmissionSFX(int playerId)`

`private bool PlayerIsHoldingAnotherWalkieTalkie(WalkieTalkie walkieTalkie)`

`private IEnumerator speakingIntoWalkieTalkieMode()`

`public void SetLocalClientSpeaking(bool speaking)`

`SendWalkieTalkieStartTransmissionSFX(playerId);`

`StartOfRound.Instance.UpdatePlayerVoiceEffects();`

`RoundManager.PlayRandomClip(allWalkieTalkies[i].thisAudio, allWalkieTalkies[i].startTransmissionSFX);`

`public AudioSource thisAudio;`
- `private void SendWalkieTalkieEndTransmissionSFX(int playerId)` -> `RoundManager.PlayRandomClip(allWalkieTalkies[i].thisAudio, allWalkieTalkies[i].stopTransmissionSFX);`
- `private void SendWalkieTalkieStartTransmissionSFX(int playerId)` -> `RoundManager.PlayRandomClip(allWalkieTalkies[i].thisAudio, allWalkieTalkies[i].startTransmissionSFX);`
- `thisAudio.PlayOneShot(switchWalkieTalkiePowerOn);`
- `thisAudio.PlayOneShot(switchWalkieTalkiePowerOff);`


`public AudioClip[] stopTransmissionSFX;`

`public AudioClip[] startTransmissionSFX;`


### RoundManager

`public static int PlayRandomClip(AudioSource audioSource, AudioClip[] clipsArray, bool randomize = true, float oneShotVolume = 1f, int audibleNoiseID = 0)`

### StartOfRound

`public void UpdatePlayerVoiceEffects()`
- seems like this is the method we want to account for walkie noise
- <mark>this manages who hears what audio, and how it sounds</mark>

### Sound Manager
- 


### PlayerControllerB

``


## Related Mods
- https://thunderstore.io/c/lethal-company/p/unity/WalkieVolume/
  - The configuration appears to be done in LethalConfigManager, not during the game
- https://thunderstore.io/c/lethal-company/p/Larkooo/FrequencyWalkie/
  - Has some interesting usage of `HUDManager.Instance.DisplayTip`
  - Has some interesting textures drawn onto the walkie's screen
- https://thunderstore.io/c/lethal-company/p/Suskitech/AlwaysHearActiveWalkies/