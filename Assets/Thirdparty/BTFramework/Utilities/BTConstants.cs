using UnityEngine;
using System.Collections;

namespace BT {

	public enum BTResult {
		Success,
		Failed,
		Running,
	}

	public enum BTAbortOpt {
		None,
		Self,
		LowerPriority,
		Both,
	}

	public enum BTClearOpt {
		Default,
		Selected,
		DefaultAndSelected,
		All,
	}

	public enum BTLogic {
		And,
		Or,
	}

	public enum BTExecuteOpt {
		OnTick,
		OnClear,
		Both,
	}

	public enum BTDataReadOpt {
		ReadAtBeginning,
		ReadEveryTick,
	}

    /// <summary>
    /// ������������
    /// by zs
    /// </summary>
    public enum BTConditionOpt
    {
        None,
        KeyCode
    }

    /// <summary>
    /// ���Ĺ�������
    /// </summary>
    public enum BTCheckAttackOpt
    {
        None,
        Common,
        Skill_1,
        Skill_2
    }



}