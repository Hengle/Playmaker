using UnityEngine;
using HutongGames.PlayMaker;
using Noesis;

namespace HutongGames.PlayMaker.Actions.NoesisGUI
{
    [ActionCategory("NoesisGUI")]
    [Tooltip("Gets the maximum width constraint of the element")]
    public class GetMaxWidth : FsmStateAction
    {
        [RequiredField]
        [UIHint(UIHint.Variable)]
        public FsmObject element;

        [RequiredField]
        [UIHint(UIHint.Variable)]
        public FsmFloat width;

        public override void OnEnter()
        {
            if (element != null)
            {
                if (element.Value is SystemObject)
                {
                    var control = ((SystemObject)element.Value).Object as Noesis.Control;
                    if (control != null)
                    {
                        width.Value = control.MaxWidth;
                    }
                }
            }

            Finish();
        }
    }
}
