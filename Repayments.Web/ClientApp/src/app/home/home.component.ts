import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  public loading = true;
  public customerSummaries: CustomerSummary[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<CustomerSummary[]>(baseUrl + 'CustomerSummary')
    .subscribe(result => {
      this.customerSummaries = result;
      this.loading = false;
    }, error => console.error(error));
  }
}

 interface CustomerSummary {
  customerName: string;
  seasonName: string;
  totalCredit: number;
  totalRepaid: number;
}