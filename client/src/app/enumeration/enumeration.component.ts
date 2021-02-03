import { Component, OnInit } from '@angular/core';
import { Enumeration } from './Enumeration';
import { EnumerationService } from './Enumeration.service';

@Component({
  selector: 'app-enumeration',
  templateUrl: './enumeration.component.html',
  styleUrls: ['./enumeration.component.scss'],
})
export class EnumerationComponent implements OnInit {
  constructor(public serviceEnum: EnumerationService) {}
  createEnum:Enumeration={
    'code':0,
    'displayFr':'',
    'idParent':'',
    'value':''
  };
   
  ajouterEnumeration(){
    // this.serviceEnum.addEnum(this.createEnum).subscribe();
    }
  ngOnInit(): void {
    console.log(this.serviceEnum.getEnums());
  }
}
