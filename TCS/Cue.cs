using System;

public class Cue
{ 
    public int NewScreenNumber;
    public int CueNumberForInput;
    public string TypeoOfChange;
    public int StartingGain;
    public int StartingFrequency;
    public int EndingGain;
    public int EndingFrequency;
    public int StartingTactorLocation;
    public int EndingTactorLocation;
    public int StartingISI;
    public int EndingISI;
    public int StartingPulseDuration;
    public int EndingPulseDuration;
    public int StartChangeAfterPulseNumber;
    public int EndChangeAfterPulseNumber;
    public DateTime presentTime;

    // cues variables
    public int TactorNum; // number of tactor sites in stimulus: 2,3
    public int ISILength; // ISI length: 0,400,900
    public string TransientType; // transient type: None, Adjacent Mud, Opposite Mud
    public string TransientTiming; // either 'Coincident' or 'Mid-ISI'

}