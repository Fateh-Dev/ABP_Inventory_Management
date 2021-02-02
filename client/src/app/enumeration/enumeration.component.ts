import { Component, OnInit } from '@angular/core';
import { EnumerationService } from './Enumeration.service';

@Component({
  selector: 'app-enumeration',
  templateUrl: './enumeration.component.html',
  styleUrls: ['./enumeration.component.scss'],
})
export class EnumerationComponent implements OnInit {
  constructor(private serviceEnum: EnumerationService) {}

  ngOnInit(): void {
    this.serviceEnum.getEnums();
  }
}
