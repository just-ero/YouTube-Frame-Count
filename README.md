# YouTube Frame Count
This tool is meant to be an improvement upon [Slush Puppy's Retime Tool](https://github.com/Slush0Puppy/retime), aimed at a slightly broader audience. This tool operates similarly, but is much more lightweight, pretty, and user friendly.
![GUI](https://i.imgur.com/tBLspvZ.png)

---
## How to use this tool
1. Find the starting frame of your video
  - use the `,` and `.` keys of your keyboard to move frame-by-frame in the video
2. Right-click the video and choose "Copy debug info"
3. Click the box next to "Start time:" and hit Ctrl + V on your keyboard
4. Repeat the above steps with the end time

Once completed, the "Delta" box will display the difference between the two timestamps. Here, you can either copy the time by clicking the clipboard, or copy a ***custom message*** by right-clicking the clipboard.  
Additionally, you can define an offset that adds or subtracts time from the delta. Right-clicking the offset box allows you to reset it back to 0.  

The time-stamped link can also be right-clicked to copy.
## Custom message
The tool comes with a file titled `YTFC_custom.txt`. Open it to edit your custom clipboard message.  
You can use the following placeholders:
* `$start$`: the start time
* `$end$`: the end time
* `$delta$`: the difference between start and end
* `$fps$`: the maximum framerate of the video
* `$offset$`: the user-defined offset