using UnityEngine;

public class GameManager : MonoBehaviour
{
    public DeckManager deckManager;

    public PlayerController player;
    public DealerController dealer;
    void Start()
    {
        Debug.Log("Game started");
        startRound();
    }
    void OnEnable()
    {
        player.ActionChosen += onAction;
        dealer.ActionChosen += onAction;
    }

    void OnDisable()
    {
        player.ActionChosen -= onAction;
        dealer.ActionChosen -= onAction;
    }

    public void onAction(ISeat who, BlackjackAction action)
    {
        if (action == BlackjackAction.Hit)
        {
            CardData card = deckManager.drawDeckCard(who.hand);
            who.hand.addCard(card);
            Debug.Log($"Next turn. Current {who} Worth: {who.hand.GetWorth()}");
        }
        else if (action == BlackjackAction.Stand)
        {
            who.isStanding = true;
            Debug.Log($"Next turn. Current {who} Worth: {who.hand.GetWorth()}");
        }
        nextTurn(who);
    }
    public void nextTurn(ISeat currentUser)
    {
        if (currentUser == (ISeat)player)
        {
            dealer.dealerDecision();
        }
        if (currentUser == (ISeat)dealer)
        {

        }
        if (dealer.isStanding && player.isStanding)
        {
            endRound();
        }

    }

    void startRound() {
        
        dealer.isStanding = false;
        dealer.hand.ClearHand();

        player.isStanding = false;
        player.hand.ClearHand();
        
        deckManager.restartDeck();

        player.hand.addCard(deckManager.drawDeckCard(player.hand));
        player.hand.addCard(deckManager.drawDeckCard(player.hand));
        Debug.Log($"Started Round. Current Player Worth: {player.hand.GetWorth()}");

        dealer.hand.addCard(deckManager.drawDeckCard(dealer.hand));
        dealer.hand.addCard(deckManager.drawDeckCard(dealer.hand));
        Debug.Log($"Started Round. Current Dealer Worth: {dealer.hand.GetWorth()}");

    }
    void endRound()
    {

        int playerWorth = player.hand.GetWorth();
        int dealerWorth = dealer.hand.GetWorth();

        int playerDifference = Mathf.Abs(playerWorth - 21);
        int dealerDifference = Mathf.Abs(dealerWorth - 21);

        if (playerDifference < dealerDifference) {
            //Player wins
            Debug.Log($"Player Win. Player Worth: {playerWorth}, Dealer Worth: {dealerWorth}");
        }
        else if (playerDifference > dealerDifference)
        {
            //Dealer wins
            Debug.Log($"Dealer Win. Player Worth: {playerWorth}, Dealer Worth: {dealerWorth}");
        }
        else
        {
            Debug.Log($"Draw. Player Worth: {playerWorth}, Dealer Worth: {dealerWorth}");
            //Draw
        }

        startRound();
    }
}
