import { Component, OnInit } from '@angular/core';
import { Word } from 'src/app/shared/models/word.model';
import { WordService } from 'src/app/shared/services/word.service';

@Component({
  selector: 'app-word',
  templateUrl: './word.component.html',
  styleUrls: ['./word.component.css']
})
export class WordComponent implements OnInit {

  wordList: Word[]=[];

  constructor(private wordService: WordService) { }

  ngOnInit(): void {
  }
  
  getAllWord()
  {
    
  }

}
