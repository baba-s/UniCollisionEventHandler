# UniCollisionEventHandler

他のゲームオブジェクトの当たり判定を検知できるコンポーネント

## 使用例

```cs
using Kogane;
using UnityEngine;

public class Example : MonoBehaviour
{
    public CollisionEventHandler m_handler;

    private void Awake()
    {
        m_handler.onCollisionEnter   += other => Debug.Log( other );
        m_handler.onCollisionStay    += other => Debug.Log( other );
        m_handler.onCollisionExit    += other => Debug.Log( other );
        m_handler.onTriggerEnter     += other => Debug.Log( other );
        m_handler.onTriggerStay      += other => Debug.Log( other );
        m_handler.onTriggerExit      += other => Debug.Log( other );
        m_handler.onCollisionEnter2D += other => Debug.Log( other );
        m_handler.onCollisionStay2D  += other => Debug.Log( other );
        m_handler.onCollisionExit2D  += other => Debug.Log( other );
        m_handler.onTriggerEnter2D   += other => Debug.Log( other );
        m_handler.onTriggerStay2D    += other => Debug.Log( other );
        m_handler.onTriggerExit2D    += other => Debug.Log( other );
    }
}
```
