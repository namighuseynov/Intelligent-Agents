using UnityEngine;

namespace IntelligentSimulator
{
    namespace AI
    {
        public abstract class Agent : MonoBehaviour
        {
            public abstract void Observe();

            public abstract void MakeDecision();

            public abstract void ReceiveMessage();
        }
    }
}