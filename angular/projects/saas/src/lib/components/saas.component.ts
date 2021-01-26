import { Component, OnInit } from '@angular/core';
import { SaasService } from '../services/saas.service';

@Component({
  selector: 'lib-saas',
  template: ` <p>saas works!</p> `,
  styles: [],
})
export class SaasComponent implements OnInit {
  constructor(private service: SaasService) {}

  ngOnInit(): void {
    this.service.sample().subscribe(console.log);
  }
}
