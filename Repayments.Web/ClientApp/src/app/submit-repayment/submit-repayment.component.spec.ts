import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SubmitRepaymentComponent } from './submit-repayment.component';

describe('SubmitRepaymentComponent', () => {
  let component: SubmitRepaymentComponent;
  let fixture: ComponentFixture<SubmitRepaymentComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SubmitRepaymentComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SubmitRepaymentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
