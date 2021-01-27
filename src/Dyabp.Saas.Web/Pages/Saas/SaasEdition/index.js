$(function () {

    var l = abp.localization.getResource('Saas');

    var service = dyabp.saas.saasEdition;
    var createModal = new abp.ModalManager(abp.appPath + 'Saas/SaasEdition/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Saas/SaasEdition/EditModal');

    var dataTable = $('#SaasEditionTable').DataTable(abp.libs.datatables.normalizeConfiguration({
        processing: true,
        serverSide: true,
        paging: true,
        searching: false,
        autoWidth: false,
        scrollCollapse: true,
        order: [[0, "asc"]],
        ajax: abp.libs.datatables.createAjax(service.getList),
        columnDefs: [
            {
                rowAction: {
                    items:
                        [
                            {
                                text: l('Edit'),
                                visible: abp.auth.isGranted('Saas.SaasEdition.Update'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                visible: abp.auth.isGranted('Saas.SaasEdition.Delete'),
                                confirmMessage: function (data) {
                                    return l('SaasEditionDeletionConfirmationMessage', data.record.id);
                                },
                                action: function (data) {
                                    service.delete(data.record.id)
                                        .then(function () {
                                            abp.notify.info(l('SuccessfullyDeleted'));
                                            dataTable.ajax.reload();
                                        });
                                }
                            }
                        ]
                }
            },
            {
                title: l('SaasEditionDisplayName'),
                data: "displayName"
            },
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewSaasEditionButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
