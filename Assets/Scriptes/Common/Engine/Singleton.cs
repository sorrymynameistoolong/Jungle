using System;

/// <summary>
/// ���͵����࣬���е����ɼ̳д��࣬��ʵ��IInit�ӿ�
/// by zs
/// </summary>
/// <typeparam name="T"></typeparam>
public class Singleton<T> where T: IInit,new()
{
    protected static T instance;

    static Singleton()
    {
        T local = default(T);
        Singleton<T>.instance = (local == null) ? Activator.CreateInstance<T>() : default(T);
        Singleton<T>.instance.Init ();
    }

    protected Singleton()
    {
    }
    
    public static T Instance
    {
        get
        {
            return Singleton<T>.instance;
        }
    }
}

public interface IInit{
    void Init();
}

