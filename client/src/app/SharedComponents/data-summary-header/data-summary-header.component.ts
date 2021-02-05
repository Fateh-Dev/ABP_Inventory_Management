import { Component, OnInit } from '@angular/core';
export interface summaryHeaderItem{
  title: string,
  data: string,
  summary: string
}
@Component({
  selector: 'app-data-summary-header',
  templateUrl: './data-summary-header.component.html',
  styleUrls: ['./data-summary-header.component.scss']
})
// tslint:disable-next-line: class-name

export class DataSummaryHeaderComponent implements OnInit {
  items: summaryHeaderItem[] = [];
  constructor() { }

  ngOnInit(): void {
    this.items=[
      {title:'fateh',data:'teste',summary:'teste'},
      {title:'fateh',data:'fateh',summary:'teste'},
      {title:'fateh',data:'teste',summary:'fateh'},
      {title:'fateh',data:'teste',summary:'teste'},
    ]
  }

}
