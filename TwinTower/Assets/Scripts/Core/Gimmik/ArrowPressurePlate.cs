using System;
using System.Collections;
using System.Collections.Generic;
using TwinTower;
using UnityEngine;

public class ArrowPressurePlate : PressurePlate {
    private SpriteRenderer sprite;
    private void Awake() {
        sprite = GetComponent<SpriteRenderer>();
    }

    protected override void OnTriggerEnter2D(Collider2D other) {
        if (sprite.color == new Color(140f/255f, 140f/255f, 140f/255f)) return;
        if (other.gameObject.layer == LayerMask.NameToLayer("Player") ||
            other.gameObject.layer == LayerMask.NameToLayer("Box"))
        {
            ActivateObject active = activateObject.GetComponent<ActivateObject>();
            active.Launch();
            sprite.color = new Color(140f/255f, 140f/255f, 140f/255f);
        }
    }

    // 발판과 연결되어 있는 activateObject를 UnLaunch시킴.(문 닫기)
    protected override void OnTriggerExit2D(Collider2D other) {
        return;
    }
}
