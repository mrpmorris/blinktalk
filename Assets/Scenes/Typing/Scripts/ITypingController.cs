﻿using UnityEngine;

namespace BlinkTalk.Typing
{
    public interface ITypingController
    {
        RectTransform GetInputSelectionPanel();
        RectTransform GetWordSelectionPanel();
        RectTransform GetKeyboardSelectionPanel();

        void StartInputStrategy<TStrategy>()
            where TStrategy : MonoBehaviour, IInputStrategy;
        void InputStrategyFinished();
        void SetIndicatorRect(RectTransform target);
    }
}
