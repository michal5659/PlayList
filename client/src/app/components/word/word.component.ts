import { Component, OnInit } from '@angular/core';
import { ThemePalette } from '@angular/material/core';
import { Word } from 'src/app/shared/models/word.model';
import { WordCategory } from 'src/app/shared/models/wordCategory.model';
import { WordCategoryService } from 'src/app/shared/services/word-category.service';
import { WordService } from 'src/app/shared/services/word.service';



@Component({
  selector: 'app-word',
  templateUrl: './word.component.html',
  styleUrls: ['./word.component.css']
})
export class WordComponent implements OnInit {

  checked = false;
  indeterminate = false;
  labelPosition: 'before' | 'after' = 'after';
  disabled = false;
  selectedcategoryId:number;
wordCategories:WordCategory[]=[]
words:WordCategory[]=[]
wordList: Word[]=[];
  constructor(private wordCategoryService: WordCategoryService) { }

  ngOnInit(): void {
    this.GetCategoryListForClass(1);
  }
  selectcategory(categoryNum:number){
    debugger;
    this.wordCategoryService.GetCategoryListForClass(1).subscribe((categories:WordCategory[])=>{
      this.words=categories
      this.selectedcategoryId=categoryNum;
    })
  }
  GetCategoryListForClass(classId){
this.wordCategoryService.GetCategoryListForClass(classId).subscribe((categories:WordCategory[])=>this.wordCategories=categories)
  }
  selectWord(categoryNum:number)
  {
    debugger
    this.wordCategoryService.GetWordsById(categoryNum).subscribe((word: Word[]) => this.wordList = word)
  }

  
}
