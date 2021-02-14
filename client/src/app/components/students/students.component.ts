import { Component, OnInit, ViewChild } from '@angular/core';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';

export interface PeriodicElement {
  name: string;
  position: number;
  weight: string;
  symbol: string;
}

const ELEMENT_DATA: PeriodicElement[] = [
  {position: 1, name: 'חיות', weight: 'bear', symbol: 'דב'},
  {position: 2, name: '', weight: 'cat', symbol: 'חתול'},
  {position: 3, name: '', weight: 'dog', symbol: 'כלב'},
  {position: 4, name: '', weight: 'duck', symbol: 'ברווז'},
  {position: 5, name: '', weight: 'lion', symbol: 'אריה'},
  {position: 6, name: '', weight: 'rabbit', symbol: 'ארנבת'},
  {position: 7, name: '', weight: 'bee', symbol: 'דבורה'},
  {position: 8, name: '', weight: 'fish', symbol: 'דג'},
  {position: 9, name: '', weight: 'wolf', symbol: 'זאב'},
  {position: 10, name: '', weight: 'donkey', symbol: 'חמור'},
];

@Component({
  selector: 'app-students',
  templateUrl: './students.component.html',
  styleUrls: ['./students.component.css']
})
export class StudentsComponent implements OnInit {


  displayedColumns: string[] = ['position', 'name', 'weight', 'symbol'];
  dataSource = new MatTableDataSource(ELEMENT_DATA);

  @ViewChild(MatSort) sort: MatSort;

  ngAfterViewInit() {
    this.dataSource.sort = this.sort;
  }

  constructor() { }

  ngOnInit(): void {
  }

}
