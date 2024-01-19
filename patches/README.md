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

### SoundManager
- 


### PlayerControllerB

``


## Related Mods

### Walkie Mods
- https://thunderstore.io/c/lethal-company/p/unity/WalkieVolume/
  - The configuration appears to be done in LethalConfigManager, not during the game
- https://thunderstore.io/c/lethal-company/p/Larkooo/FrequencyWalkie/
  - Has some interesting usage of `HUDManager.Instance.DisplayTip`
  - Has some interesting textures drawn onto the walkie's screen
- https://thunderstore.io/c/lethal-company/p/Suskitech/AlwaysHearActiveWalkies/

### Auxilary Mods
- https://thunderstore.io/c/lethal-company/p/2018/LC_API/


### Custom Sound Mods
- https://thunderstore.io/c/lethal-company/p/no00ob/LCSoundTool/
  - mod allows you to replace any sound in the game
  - can replace a sound with one or multiple options
  - mod is fully client side
  - to replace sound without requiring a custom mod, use: https://thunderstore.io/c/lethal-company/p/Clementinise/CustomSounds/
- https://thunderstore.io/c/lethal-company/p/Clementinise/CustomSounds/
  - lets you replace game's default sounds with your own custom sounds
  - requires: https://thunderstore.io/c/lethal-company/p/no00ob/LCSoundTool/

## Helpful Videos
- [Lethal Company - How to write your own mod from scratch! - YouTube](https://www.youtube.com/watch?v=4Q7Zp5K2ywI)
- [How to setup BepInEx with Lethal Company and install/configure mods (youtube.com)](https://www.youtube.com/watch?v=eXA60ZWMI4M&t=0s)
- [Lethal Company - How to mod in your own sounds from scratch! (youtube.com)](https://www.youtube.com/watch?v=UDfC9uZnrFo&t=1s)