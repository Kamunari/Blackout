# Blackout

A custom gamemode for SCP:SL.

# Backstory

Dr. Bright woke up on a Saturday morning, today was his day to make the company's morning tea. As he was bringing cups to his co-workers, he tripped on a wire and spilled some tea all over a loose outlet. The circuit breaker tripped and the facility suddenly lost power. In a craze for their morning tea, all of the employees grabbed flashlights and went out in search for the generators to get the power back up. They passed by SCP-049s containment chamber and saw that the backup generator for his door malfunctioned.
*The door was wide open.*

# Gameplay

When the round starts, all players will be in SCP-049s chamber, the door will be locked. After 30 seconds, the lights will flicker and shut off. A few players will spawn as 049 in various places around heavy containment at thsi time, SCP-049s door will open, and the scientists will be let free with nothing but a keycard, weapon manager tablet, and flashlight. Their goal is to reactivate all 5 generators in heavy containment and escape before SCP-049 kills them. After doing so they can open the heavy containment armory door to escape, in which they will spawn as a Nine Tailed Fox Scientist with weapons. They must now eliminate all SCP-049s before time is up.

# Installation

**[Smod2](https://github.com/Grover-c13/Smod2) must be installed for this to work.**

Place the "Blackout.dll" file in your sm_plugins folder.

# Commands

| Command        | Description |
| :-------------: | :------ |
| BLACKOUT | Enabled Blackout for the next round only. |
| BLACKOUT TOGGLE | Toggles Blackout on or off. |

# Configs

| Config        | Value Type | Default | Description |
| :-------------: | :---------: | :---------: |:------ |
| bo_ranks | List |  | Ranks allowed to run the `BLACKOUT` command. |
| bo_flashlights | Boolean | True | If scientists should get a flashlight on spawn. |
| bo_slendy_percent | Float | 0.1 | Percentage of players that should be slendies (SCP-049). |
| bo_max_time | Integer | 7 | Time in minutes before the round ends. |
| bo_respawn_time | Float | 15 | Time before a dead scientist respawns with nothing in 049 (if respawn is enabled via command). |
| bo_usp_time | Float | 300 | Time in seconds before a USP spawns in nuke armory. |
| bo_start_delay | Float | 30 | Time in seconds until the round starts. |
| bo_tesla_flicker | Boolean | True | If teslas should activate on light flicker. |
