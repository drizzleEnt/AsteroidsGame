using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopBorder : Borders
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Player>(out Player player))
            ChengePlayerPosition();
    }

    protected override void ChengePlayerPosition()
    {
        Player.transform.position = new Vector2(Player.transform.position.x, PositionY);
    }
}
