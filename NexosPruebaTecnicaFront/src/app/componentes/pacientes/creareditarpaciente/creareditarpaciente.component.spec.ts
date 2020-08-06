import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CreareditarpacienteComponent } from './creareditarpaciente.component';

describe('CreareditarpacienteComponent', () => {
  let component: CreareditarpacienteComponent;
  let fixture: ComponentFixture<CreareditarpacienteComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CreareditarpacienteComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CreareditarpacienteComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
