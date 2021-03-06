﻿using WCell.Constants;
using WCell.RealmServer.Modifiers;

namespace WCell.RealmServer.Spells.Auras.Handlers
{
    public class ModIncreaseEnergyPercentHandler : AuraEffectHandler
    {
        protected override void Apply()
        {
            this.m_aura.Auras.Owner.ChangeModifier(StatModifierInt.PowerPct, this.EffectValue);
        }

        protected override void Remove(bool cancelled)
        {
            this.m_aura.Auras.Owner.ChangeModifier(StatModifierInt.PowerPct, -this.EffectValue);
        }
    }
}