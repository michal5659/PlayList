import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-game',
  templateUrl: './game.component.html',
  styleUrls: ['./game.component.css']
})
export class GameComponent implements OnInit {
  href:string="file:///C:/Users/user/Desktop/לימודים/פרוייקט%20גמר/משחקים/memory-game-javascript-master/memory-game-javascript-master/index.html?id=";
num:number = 207067307
  constructor() { }

  ngOnInit(): void {
    this.href = this.href + this.num;
  }

}
