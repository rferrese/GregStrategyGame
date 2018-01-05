﻿using System.Collections.Generic;

public class BattleRound
{
    private readonly IEnumerable<UnitStateRecord> _units;
    public IEnumerable<UnitStateRecord> Units { get{ return _units; } }

    private readonly BattleStatus _status;
    public BattleStatus Status { get{ return _status; } }

    private readonly IEnumerable<CombatLogItem> _combatLog;
    public IEnumerable<CombatLogItem> CombatLog { get{ return _combatLog; } }
    
    public BattleRound(IEnumerable<UnitStateRecord> units, BattleStatus status, IEnumerable<CombatLogItem> combatLog)
    {
        _units = units;
        _status = status;
        _combatLog = combatLog;
    }
}