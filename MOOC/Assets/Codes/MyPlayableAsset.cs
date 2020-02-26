using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

public class MyPlayableAsset : PlayableAsset
{
    public ExposedReference<Text> myText;
    public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
    {
        var playable = ScriptPlayable<MyPlayableBehaviour>.Create(graph);
        playable.GetBehaviour().status = myText.Resolve(graph.GetResolver());
        return playable;
    }
}

public class MyPlayableBehaviour : PlayableBehaviour
{
    public Text status;
    public override void OnBehaviourPlay(Playable playable, FrameData info)
    {
        base.OnBehaviourPlay(playable, info);
        if (status != null)
        {
            status.gameObject.SetActive(true);
            status.text = "Playing";
        }
    }

    public override void OnBehaviourPause(Playable playable, FrameData info)
    {
        if (status != null)
        {
            status.text = "End playing";
        }
        base.OnBehaviourPause(playable, info);
        
    }
}
