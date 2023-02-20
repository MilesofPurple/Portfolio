package alexmilesbulgariansolitaire;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;
import java.util.Random;

//author: Alex Miles

public class BulgarianSolitaire {
	
	ArrayList<Integer> active = new ArrayList<Integer>();  //array to hold the numbers after calculation
	ArrayList<Integer> history = new ArrayList<Integer>(); //array to keep track of the numbers last drawn
	ArrayList<Integer> winner = new ArrayList<Integer>(); //array to trigger win
	
	Random rn = new Random();
	
	
	public static void main(String[] args) {
		BulgarianSolitaire game = new BulgarianSolitaire();
	}//main
	
	BulgarianSolitaire() {
		int deck = 45; //initial size of deck
		int round = 1; //cosmetic round counter

		System.out.println("Shuffling cards.");
		do { 
		    int number = rn.nextInt(deck) + 1; //randomly picks a number from remaining in deck variable
		    active.add(number); //adds that number
		    deck = (deck - number); //deletes that number from the deck
		} while (deck != 0); //do
		Collections.sort(active);
		System.out.println("Starting Bulgarian Solitaire:");
		do {
			System.out.println("Round "+ round + ": " + active);
			round++;
			removecard();
		} while (check() == false);
		if (check() == true) {
			System.out.println("Final Round: " + active);
			System.out.println("You win!");
		}
	}//BulgarianSolitaire
	
	public void removecard() { //removes value of 1 from each element, adds the sum of deletion cycles to array
		int count = 0;
		for (int i = 0; i < active.size(); i++) {
			int temp = active.get(i);
			active.set(i, temp - 1);
			count++;
		}//for
		active.add(count);
		removezero(active);
		Collections.sort(active);
	}//removecard
	
	public void removezero(ArrayList<Integer> list) { //method for removing zeros from an arraylist
		for (int j = 0; j < list.size(); j++) {
			if (list.get(j) == 0) {
				list.remove(j);
				j--;
			}//if
		}//for
	}//removezero
	
	public boolean check() { //checking for 123456789 sequence.
	    int k = 0;
		for(k = 0; k < active.size(); k++) {
	        if(active.get(k) != k + 1) {
	            return false;
	        }
	    }
	    return true;
	}
	
}//class
